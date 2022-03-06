import os
import shutil

def main():
    dir_path = input("Enter the directory path: ")
    file_dict = {}

    for root, dirs, files in os.walk(dir_path):
        for file in files:
            ext = file.split('.')[-1]
            if ext not in file_dict:
                file_dict[ext] = []
            file_dict[ext].append(os.path.join(root, file))

    for ext, file_list in file_dict.items():
        if not os.path.exists(os.path.join(dir_path, ext)):
            os.makedirs(os.path.join(dir_path, ext))
        for file in file_list:
            shutil.move(file, os.path.join(dir_path, ext))

if __name__ == "__main__":
    main()