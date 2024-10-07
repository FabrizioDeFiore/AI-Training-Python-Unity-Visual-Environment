
    for stream_name, data_list in zip(data_stream_names, [simulated_data["CHPTemp1"], simulated_data["LoopTemp1"], simulated_data["Stoom"]]):
        # Send data point with stream name prepended and newline added
        for data_point in data_list:
            data_string = f"{stream_name} {data_point}\n"  # Use f-string for formatted string
            s.sendall(data_string.encode('utf-8'))
            print(f"Sent: {data_string}")  # Print sent data for debugging
            # Consider adding a delay between sending data points for slower updates
            # time.sleep(0.001)
