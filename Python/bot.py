import pyautogui
from time import sleep

text = input("Mensagem a enviar: ")
times = int(input("Selecione o número de vezes que deseja enviar uma mensagem: "))

for c in range(8, 0, -1):
    print(c)
    sleep(1)

while True:
    counter = 1
    while counter <= times:
        pyautogui.write(text)
        sleep(0.5) # sleep between writing text and pressing ENTER
        pyautogui.press('enter')
        print(counter)
        counter += 1
    break
