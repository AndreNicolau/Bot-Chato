# Use this script to install the pyautogui library dependencies

import os

os.system('cls' if os.name == 'nt' else 'clear')

try:
    import pyautogui
    print('Module pyautogui imported')
except ModuleNotFoundError:
    print('Module pyautogui not found. Trying to install')
    os.system('pip install pyautogui')