import socket
import csv
import numpy as np
import pandas as pd

simulated_data = pd.read_csv("simulated_MP01.csv") 
HOST = '127.0.0.1'  # localhost
PORT = 25003
#print("simulated_data[CHPTemp1]")
print(simulated_data["CHPTemp1"])


# TAKE OF COLUMN NAME AND DATAFROMAT

# Open the CSV file and extract data from three columns
with open('simulated_mp01.csv', 'r') as csvfile:
    #reader = csv.reader(csvfile, skipinitialspace=True, skip_empty_lines=True)  # Handle whitespace, empty lines
    reader = csv.reader(csvfile)
    # Skip the first row
    next(reader)
    data_columns = list(zip(*reader))  # Transpose rows to columns
#print("data_columns[6]")
print(data_columns[6])
# Separate data into individual lists and convert to floats, handling empty strings
chp_temp_data = [float(row) if row != '' else 0.0  
                 for row in data_columns[6]] # chp column index
loop_temp_data = [float(row) if row != '' else 0.0 
                 for row in data_columns[4]] # loop column index
stoom_data = [float(row) if row != '' else 0.0  
                 for row in data_columns[30]] # stoom column index

# Connect to the server and send data streams sequentially
with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.connect((HOST, PORT))

    # Send CHPTemp1 data
    for data_point in chp_temp_data:
        data_string = str(data_point) + '\n'  # Add newline for frame separation
        s.sendall(data_string.encode('utf-8'))
        #print("data_string.encode(utf-8)")
        #print(data_string.encode('utf-8'))
        # Consider adding a delay between sending data points for slower updates
        # time.sleep(0.001)  

    # Send LoopTemp1 data 
    for data_point in loop_temp_data:
        data_string = str(data_point) + '\n'
        s.sendall(data_string.encode('utf-8'))

    # Send Stoom data
    for data_point in stoom_data:
        data_string = str(data_point) + '\n'
        s.sendall(data_string.encode('utf-8'))

