import socket
import time
import struct

class Ninja:
    """
    This class allows to a beginner in python to play 10 second ninja game.
    You will need to install python and scratch2warcraft to use this class.
    https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
    
    Buy/Download the game: 
    https://store.steampowered.com/app/271670/10_Second_Ninja/
    
    """
    
    ip_home = "127.0.0.1"
    ip_server = "apint.ddns.net"
    # SOURCE: https://github.com/EloiStree/2024_08_29_ScratchToWarcraft
    key_sword: int = 1088    # key_x 
    key_shuriken: int = 1090 # key_z
    key_continue: int = 1067 # key_c 
    key_restart: int = 1082  # key_r 
    key_jump: int = 1038     # arrow_up 
    key_left: int = 1037     # arrow_left 
    key_right: int = 1039    # arrow_right 
    key_down: int = 1040     # arrow_down 
    key_enter: int = 1013    # enter 
    key_escape: int = 1027   # escape 
    
    def __init__(self, ipv4, port, player_index, name_ninja):
        self.ipv4 = ipv4
        self.port = port
        self.player_index = player_index
        self.name_ninja = name_ninja
        
    def push_index_integer(self, index, value):
        """
        I am method that send index and integer in binarry to a target udp.
        """
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
        bytes_to_send= struct.pack('<ii', index, value)
        self.sock.sendto(bytes_to_send, (self.ipv4, self.port))

    def press_key(self, key_press: int):
        """
        I am a methode that send a integer key representation as pressed to udp target
        """
        self.push_index_integer(self.player_index, key_press)

    def release_key(self, key_press: int):
        """
        I am a methode that send a integer key representation as released to udp target
        """
        self.push_index_integer(self.player_index, key_press + 1000)

    def press_for_delay(self, key_press, delay_press=0.1, delay_release=0):
        """ 
        I am a methode that pres and release with a bit of delay between and after
        """
        
        self.press_key(key_press)
        time.sleep(delay_press)
        self.release_key(key_press)
        time.sleep(delay_release)

    def tap_key(self, key_press):
        """
        I am a methode that press and release a key quickly.
        """
        self.press_for_delay(key_press, 0.1, 0.01)

    def start_move_right(self):
        self.press_key(self.key_right)
    
    def stop_move_right(self):
        self.release_key(self.key_right)

    def start_move_left(self):
        self.press_key(self.key_left)
    
    def stop_move_left(self):
        self.release_key(self.key_left)
    
    def start_jump(self):
        self.press_key(self.key_jump)
    
    def stop_jump(self):
        self.release_key(self.key_jump)
        
    def start_sword(self):
        self.press_key(self.key_sword)
    
    def stop_sword(self):
        self.release_key(self.key_sword)
    
    def start_shuriken(self):
        self.press_key(self.key_shuriken)
    
    def stop_shuriken(self):
        self.release_key(self.key_shuriken)


    def tap_jump(self):
        self.tap_key(self.key_jump)
    
    def tap_sword(self):
        self.tap_key(self.key_sword)
    
    def tap_shuriken(self):
        self.tap_key(self.key_shuriken)
    
    def tap_continue(self):
        """
        I am a methode that will continue in the game menu: next level , next menu ...
        """
        self.tap_key(self.key_continue)
    
    def tap_restart(self):
        """
        I am a methode that will pres and release the restart key.
        """
        self.tap_key(self.key_restart)
    
    def tap_x(self):
        self.tap_key(self.key_sword)
    
    def tap_z(self):
        self.tap_key(self.key_shuriken)
    
    def tap_c(self):
        self.tap_key(self.key_continue)
    
    def tap_r(self):
        self.tap_key(self.key_restart)
    
    def tap_enter(self):
        self.tap_key(self.key_enter)
    
    def tap_escape(self):
        self.tap_key(self.key_escape)

    
    def wait_for_milliseconds(self, milliseconds):
        """
        I am a methode that will freeze the program for a certain amount of time.
        """
        time.sleep(milliseconds / 1000.0)
    
    def wait_for_seconds(self, seconds):
        """
        I am a methode that will freeze the program for a certain amount of time.
        """
        time.sleep(seconds)
   
   
   
# Initialize player
target_address = "192.168.1.250"
target_port = 7073
target_player_index = 1
player = Ninja(target_address, target_port, target_player_index, "Marcel")


class ProcessLevels:
    def process_level_one(the_ninja: Ninja):
        """
        This is a quick solution improvise as a demo.
        """
        the_ninja.tap_restart()
        the_ninja.tap_shuriken()
        
        the_ninja.start_move_right()
        the_ninja.wait_for_seconds(0.35)
        the_ninja.stop_move_right()
        the_ninja.wait_for_seconds(0.1)
        
        the_ninja.start_jump()
        the_ninja.start_move_left()
        the_ninja.wait_for_seconds(0.5)
        the_ninja.stop_jump()
        the_ninja.stop_move_left()
        the_ninja.wait_for_seconds(0.1)
        
        the_ninja.start_jump()
        the_ninja.start_move_left()
        the_ninja.start_sword()
        the_ninja.wait_for_seconds(0.5)
        the_ninja.stop_sword()
        the_ninja.stop_jump()
        the_ninja.stop_move_left()
        the_ninja.wait_for_seconds(0.2)
        
        the_ninja.start_move_right()
        the_ninja.tap_jump()
        the_ninja.tap_jump()
        the_ninja.stop_move_right()
        
        the_ninja.tap_shuriken()
        the_ninja.wait_for_seconds(3)
        
    def your_code_for_level_1(the_ninja:Ninja):
        """
        Add your code here to make less that 2 secconds in level 1.
        """
        pass
    
    def your_code_for_level_2(the_ninja:Ninja):
        """
        Add your code here to make less that 2 secconds in level 2.
        """
        pass
    def your_code_for_level_3(the_ninja:Ninja):
        """
        Add your code here to make less that 2 secconds in level 2.
        """
        pass
        
while True:
    game_mode = "SPEED"
    game_mode = "LEVELS"
    game_mode = "DEMO"
    if game_mode == "DEMO":
        print("DEMO MODE")
        while True:
            ProcessLevels.process_level_one(player)
        
    elif game_mode == "LEVELS":
        print("DEMO MODE")
        ProcessLevels.your_code_for_level_1(player)
        player.tap_continue()
        player.wait_for_milliseconds(1000)
        ProcessLevels.your_code_for_level_2(player)
        player.tap_continue()
        player.wait_for_milliseconds(1000)
        ProcessLevels.your_code_for_level_3(player)
        
    elif game_mode == "SPEED":
        
        print("DEMO MODE")
        while True:
            player.tap_restart()
            player.wait_for_milliseconds(300)
            ProcessLevels.your_code_for_level_1(player)
            
        
