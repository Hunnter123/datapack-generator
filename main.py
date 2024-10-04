import tkinter as tk
from tkinter import filedialog
import tkinter.messagebox
import os

window = tk.Tk()
window.geometry("500x700")
window.eval('tk::PlaceWindow . center')

dir = f"{os.path.expanduser('~')}/Documents"

def openfile():
    global dir
    dir = filedialog.askdirectory()
    dirlable.config(text=dir)

def place_template():
    name = name_box.get()
    os.makedirs(f"{dir}/{name}")
    meta = open(f"{dir}/{name}/pack.mcmeta", "w")
    meta.write("""{
    "pack": {
        "pack_format": 48,
        "description": "description"
    }
}""")
    meta.close()
    os.makedirs(f"{dir}/{name}/data")
    os.makedirs(f"{dir}/{name}/data/pack")
    os.makedirs(f"{dir}/{name}/data/pack/function")
    os.makedirs(f"{dir}/{name}/data/minecraft")
    os.makedirs(f"{dir}/{name}/data/minecraft/tags")
    os.makedirs(f"{dir}/{name}/data/minecraft/tags/function")

    tickfunc = open(f"{dir}/{name}/data/pack/function/tick.mcfunction", "w")
    tickfunc.write(tickscr.get("1.0", tk.END))
    tickfunc.close

    loadfunc = open(f"{dir}/{name}/data/pack/function/load.mcfunction", "w")
    loadfunc.write(loadscr.get("1.0", tk.END))
    loadfunc.close()

    tickjson = open(f"{dir}/{name}/data/minecraft/tags/function/tick.json", "w")
    tickjson.write("""{
    "values":[
      "pack:tick"
    ]
                   }""")
    tickjson.close()

    loadjson = open(f"{dir}/{name}/data/minecraft/tags/function/load.json", "w")
    loadjson.write("""{
    "values":[
      "pack:load"
    ]
}""")
    loadjson.close()

    tkinter.messagebox.showinfo("succses", "succses") 

opendir = tk.Button(window, text="open dir", padx=50, pady=10, command=openfile)
opendir.place(x=175, y=50)

dirlable = tk.Label(window, text=dir, borderwidth=1, relief="solid", anchor="center")
dirlable.pack()

# Button to place template
place = tk.Button(window, text="create pack", padx=50, pady=10, command=place_template)
place.place(x=175, y=200)

# Entry box for the template name input
name_box = tk.Entry(window, width=30)
name_box.place(x=150, y=125)

ticklable = tk.Label(window, text="tick.mcfunction")
ticklable.place(x=75, y=270)
loadlable = tk.Label(window, text="load.mcfunction")
loadlable.place(x=330, y=270)

tickscr = tk.Text(window, width=29, height=10)
tickscr.place(x=10, y=300)

loadscr = tk.Text(window, width=29, height=10)
loadscr.place(x=250, y=300)

window.mainloop()