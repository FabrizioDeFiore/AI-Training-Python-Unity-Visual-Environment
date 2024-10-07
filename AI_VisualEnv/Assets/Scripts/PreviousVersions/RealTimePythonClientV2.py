import socket
import csv
import numpy as np
import pandas as pd

# Read data from CSV using pandas
simulated_data = pd.read_csv("simulated_MP01.csv")
# Define data stream names (modify these based on your actual stream names)
data_stream_names = ["CHPTemp1", "LoopTemp1", "Stoom"]
# HOST and PORT for connection (same as before)
HOST = '127.0.0.1'  # localhost
PORT = 25001

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
    s.connect((HOST, PORT))
    
    # Iterate through data streams and corresponding data lists
    for stream_name, data_list in zip(data_stream_names, [simulated_data["CHPTemp1"], simulated_data["LoopTemp1"], simulated_data["Stoom"]]):
        # Send data point with stream name prepended and newline added
        for data_point in data_list:
            data_string = f"{stream_name} {data_point}\n"  # Use f-string for formatted string
            s.sendall(data_string.encode('utf-8'))
            print(f"Sent: {data_string}")  # Print sent data for debugging
            # Consider adding a delay between sending data points for slower updates
            # time.sleep(0.001)
