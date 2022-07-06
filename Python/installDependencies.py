from gettext import install


import os

os.system('cls' if os.name == 'nt' else 'clear')

try:
    import pyautogui
    print('Module pyautogui imported')
except ModuleNotFoundError:
    print('Module pyautogui not found. Trying to install')
    install('pyautogui')