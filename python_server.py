import socket
HOST = ''              # Endereco IP do Servidor
PORT = 9999            # Porta que o Servidor esta
udp = socket.socket(socket.AF_INET, socket.SOCK_DGRAM)
orig = (HOST, PORT)
udp.bind(orig)

EMG = []


while True:
    msg, cliente = udp.recvfrom(1024)
    EMG.append(int(msg))   
    
    print(EMG)
    
udp.close()






