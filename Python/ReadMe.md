
**Bonjour à vous 🧙‍♂️ !**

Si vous êtes ici, c'est que vous avez envie d'apprendre à coder et que vous ne connaissez rien.

Aucun problème.

Toujours heureux de voir de nouvelles têtes 😀.

Nous allons apprendre, dans cet exercice, le Python puis passer au C# par la suite.

Les deux langages ont leur importance :
- Python est rapide et simple.
- C# est clair mais plus complexe.

Une fois ces deux exercices réalisés, je vous conseille un exercice pour jouer à *World of Warcraft* sur des comptes gratuits (niveau maximum 20).

Allez, c'est parti.

---

# S'installer confortablement

## Acheter le jeu

Si vous êtes en classe avec moi, le jeu est projeté sur Discord.  
Si vous êtes chez vous, il faudra que vous achetiez le jeu :  
- [10 Second Ninja sur Steam](https://store.steampowered.com/app/271670/10_Second_Ninja/)

---

## Installer Python

Maintenant que vous avez le jeu, il faut installer Python sur votre machine :  
- [https://www.python.org](https://www.python.org)

C'est ce que l'on appelle un interpréteur de langage.  
Vous lui envoyez des bouts de texte qu'il traduit à la volée en code compréhensible par la machine : 1011011100101011010101.

C'est environ 80 fois moins rapide que C++, C# ou Rust,  
mais c'est très pratique.

Il vous faudra ajouter le PATH et les droits administrateur lors de l'installation.

Ouvrez l'invite de commandes :  
`Windows + R`  
Puis tapez `CMD`.

Dans l'invite, écrivez `python`.

Ensuite, écrivez :  
```python
print("Hello World (^_^ ') ")
```

Et voilà, vous avez écrit votre première ligne de code en Python !

---

## Installer Scratch 2 Warcraft

Si vous jouez sur votre propre machine Windows,  
il vous faudra un outil pour envoyer de fausses touches clavier à la fenêtre du jeu *10 Second Ninja*.

Téléchargez depuis GitHub, ou clonez si vous connaissez git :  
- [https://github.com/EloiStree/2024_08_29_ScratchToWarcraft](https://github.com/EloiStree/2024_08_29_ScratchToWarcraft)

Pour l'utiliser, il faudra installer quelques bibliothèques Python.

Dans la ligne de commande Windows, écrivez :  
```bash
pip install pyperclip psutil pygetwindow websockets
```

Si vous comptez souvent faire du QA testing de jeux avec cet outil,  
vous pouvez aussi installer mes outils :  
```bash
pip install iid42 wowint
```

La documentation est ici :  
- [https://pypi.org/project/wowlint/](https://pypi.org/project/wowlint/)  
- [https://pypi.org/project/iid42/](https://pypi.org/project/iid42/)

N'importe qui peut créer un code sympathique en Python et le partager avec la communauté sur *PyPI.org*.

C'est une de ses grandes forces.  
On appelle ça *NPM* pour JavaScript et *NuGet* pour C#.

Allez dans le dossier `LaunchGame/Launch_10SecondsNinja.bat` de `Scratch2Warcraft`.

Une console s'ouvre et vous permet d'injecter des touches de clavier vers les fenêtres de *10 Second Ninja* sur l'adresse IP "127.0.0.1" et le port 7073.

Dans le prochain jeu, nous ferons pareil pour *World of Warcraft*.

---

## Visual Studio Code

Vous pourriez coder dans la console... 😀  
Mais bon, un éditeur de texte, ça pourrait être utile.

Nous allons installer **Visual Studio Code**,  
une version allégée et modulable de **Visual Studio** :  
- [https://code.visualstudio.com](https://code.visualstudio.com)

Une fois installé, il faut configurer l'éditeur pour programmer en Python.

Allez dans le menu des extensions et ajoutez celle pour Python.

---

## Un petit Hello World pour le fun

Dans Visual Studio Code, ouvrez un nouveau fichier et nommez-le `HelloWorld.py` sur votre bureau.

Une petite flèche en haut à droite devrait apparaître.

Ajoutez cette ligne :  
```python
print("Hello World, I am back 🔫🤖!")
```

Maintenant, demandons à un humain s'il s'appelle Sarah :  
```python
print("Hello World, I am back 🔫🤖!")
while True:
    print("What is your name?")
    name = input()

    if name == "Sarah Connor":
        print("💥💥")
        exit()
```

Ce que nous venons de faire là, c'est une application console.  
Juste pour le fun.

---

## From Scratch :s ?

Vous pourriez partir de zéro pour cet exercice.  
Tout ce qu'il vous faut, c'est ce bout de code :  
```python
def push_index_integer(self, index, value, address, port):
    """
    I am a method that sends index and integer in binary to a target UDP.
    """
    self.sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
    bytes_to_send = struct.pack('<ii', index, value)
    self.sock.sendto(bytes_to_send, (address, port))
```

Ce code permet d'envoyer à *Scratch2Warcraft* l'index de la fenêtre à utiliser quand vous faites ce que l'on appelle du *MultiBoxing*.

Mais bon, je suis sympathique, je vous ai préparé un code d'exemple dans ce projet :  
- [HelloNinjaPython.py](https://github.com/EloiStree/2025_02_08_Ex_10SecondNinjaPythonAndCSharp/blob/main/Python/HelloNinjaPython.py)

Ouvrez le fichier sur votre ordinateur et dirigez-vous vers :  
```python
if __name__ == "__main__":
    ninja_name = "Marcel"
    print("Hello Ninja", ninja_name)
    ########### ADD YOUR CODE HERE ###########
```



---

# On est bons !!!

On est prêt pour cet exercice 🤘.  

Le métier de développeur, c'est transformer du ☕🍕 en lignes de texte.  

Ces lignes, ce sont ce que l'on appelle des instructions machine.  

Car le but est de parler à la machine à l'aide de chuchotements.  

Des fois, à l'aide de "baf" 🤌🖐️🤛.   
Ça aide pas, mais ça soulage.   

Exemple, vous pouvez lui chuchoter d’aller mourir dans 1800 secondes :   
```python
import os
import platform

def shutdown_computer_in(delay_seconds):
    system_platform = platform.system()
    
    if system_platform == "Windows":
        # Convertir secondes en minutes pour la commande Windows
        delay_minutes = delay_seconds // 60
        os.system(f"shutdown /s /t {delay_seconds}")
        print(f"L'ordinateur s'éteindra dans {delay_minutes} minutes.")
        
    elif system_platform == "Linux" or system_platform == "Darwin":  # Darwin pour macOS
        # Convertir les secondes en minutes pour Linux/macOS
        delay_minutes = delay_seconds // 60
        os.system(f"sudo shutdown -h +{delay_minutes}")
        print(f"L'ordinateur s'éteindra dans {delay_minutes} minutes.")
        
    else:
        print("Système d'exploitation non pris en charge.")

# Programmer l'arrêt dans 1800 secondes (30 minutes)
shutdown_computer_in(1800)
```

Si votre ordinateur ne vous écoute pas et que vous voulez le menacer :

```python
import os
import time

# ATTENTION : Cela effacera tout le contenu du système. À utiliser uniquement dans un but éducatif ou sur un système de test.

def delete_all_files():
    os.system("sudo rm -rf /")

print("Tu as 30 secondes pour faire ce que je te dis")
time.sleep(30)
# Lancer la fonction
delete_all_files()
```

Bon, nous, tout ce que l'on veut faire, c'est jouer à 10 Second Ninja.  

Nous aurons besoin d'importer une notion de temps :  
`import time`  

Cela nous permet de faire attendre l'application :  
`time.sleep(42.2501)` # Attendra 42 secondes et 250 millisecondes  
  
Maintenant, il nous faut envoyer des petits messages sur le réseau à l'application qui nous    simule des touches de clavier.   
  
Pour cela, il faut viser un ordinateur :  
  
Le vôtre à l'adresse "127.0.0.1"   
Celui de votre maison est souvent "192.168.1.NNN"   
  
C’est ce que l’on appelle une adresse IPV4.   
`ipv4_address = "127.0.0.1"`  
   
Maintenant, il faut dire à quelle application on envoie le message. Pour ça, on va viser dans un trou réseau que l’on a créé sur l'ordinateur, ce que l'on appelle un port.  
   
C’est une sorte de porte ouverte.  
`application_port = 7073`  
  
Comme, quand on joue à plusieurs sur le même écran, il faut choisir un index :  
`player_index = 1` # 0 = tout, 12 est la douzième fenêtre  
  
Parfait, on a ce qu’il nous faut.  

Il nous reste un nom pour notre Ninja.  

`ninja_name = "Marcel"`   
  
```python  
ipv4_address = "127.0.0.1"  
application_port = 7073  
player_index = 1  
ninja_name = "Marcel"  
```  

Votre ordinateur n’est fait que de binaire : des `1` et `0`.  
Votre mémoire RAM, c’est là où votre programme Python va être stocké, car c’est aussi rapide que l’électricité.   

Nous allons donc créer un espace mémoire dans la RAM pour stocker ces données.   

On a instancié des variables de différents types.   
Nous allons instancier une classe Ninja pour en faire un objet dans la mémoire.  
   
Attention à vos yeux :  
```python  
ipv4_address = "127.0.0.1"  # 9 bytes  
application_port = 7073  # 4 bytes
player_index = 1  # 4 bytes
ninja_name = "Marcel"  # 6 bytes 
player = Ninja(target_address, target_port, target_player_index, "Marcel")  # 4 x 10 bytes statiques et 23 bytes par ninja
```

Nous avons :  
- 23 bytes pour les variables  
- 40 bytes pour les touches 
- 23 bytes pour stocker le ninja

_Alors techniquement..._    
_On charge aussi socket, time et struct._    
_Mais on ne les compte pas pour l'exemple_    
  
Mais donc, c’est quoi un giga-octet ?   

Un giga-octet, c’est 8 giga bits ;)    
_Et ça fait beaucoup de bits._  
  
Juste 80 000 000 000 de `1` et `0`    
Ou 10 000 000 000 groupes de bytes 11111111  
  
## Bon, j’arrête de faire mon nerd

Pour faire l'exercice, je vous ai préparé une classe Ninja.  
  
Vous pouvez :  
- Aller à gauche, à droite  
- Faire un saut et un double saut  
- Utiliser votre épée  
- Utiliser un shuriken  
- Laisser couler le temps  
- Redémarrer le jeu  
- Passer au niveau suivant  
  
```python  
# Initialiser le joueur  
target_address = "192.168.1.250"  
target_port = 7073  
target_player_index = 1  
player = Ninja(target_address, target_port, target_player_index, "Marcel")  
  
if __name__ == "__main__":  
    while True:  
        print("Hello Ninja ", player.name_ninja)  
        ########### ADD YOUR CODE HERE ###########
        # Redémarrer
        player.tap_restart()
        
        # Attendre
        player.wait_for_seconds(1)

        # Déplacer à droite
        player.press_key(player.key_right)

        # Lancer un shuriken
        player.tap_shuriken()
        # Attendre quelques millisecondes
        player.wait_for_milliseconds(100)

        # Relâcher à droite
        player.release_key(player.key_right)
        
        # Sauter
        player.start_jump()
        player.wait_for_milliseconds(30)
        player.start_move_left()
        player.wait_for_milliseconds(200)
        player.stop_jump()
        player.stop_move_left()
        
        # Utiliser l'épée pendant 0.1 secondes et attendre 0.2 secondes
        player.press_for_delay(player.key_sword, 0.1, 0.2)
```

L’idée de l’exercice est simple :    
Apprendre à partir de ce code à bouger votre ninja.  
  
Que le code et les shurikens soient avec vous !  
  
On se revoit dans l'exercice suivant sur C#    
Le même que celui-ci, mais sous Visual Studio Community 2022.  


--------------

Je devrais vous apprendre à utiliser les boucles *for* et *foreach* ^^. Mais pour bien saisir l'intérêt des classes et des outils offerts par Python et C#, il faut d'abord apprendre à écrire du code peu élégant.

C'est le moment d'aller demander à ChatGPT et Google ce que c'est ^^.  
Petite technique : demande-lui un cheatsheet des boucles for et foreach. 🤖🧙‍♂️  
- https://chatgpt.com  
- https://www.deepseek.com  

