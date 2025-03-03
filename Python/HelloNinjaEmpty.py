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
