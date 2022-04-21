#!/bin/env python3
import sys
import sqlite3
import csv

def main():
    with open("medicine.csv") as file:
        csvreader = csv.reader(file)
        con = sqlite3.connect('data.db')
        cur = con.cursor()
        i = 0
        for row in csvreader:
            try:
                cur.execute("INSERT INTO medicines(name, dosage, unit) VALUES ('" + row[0] + "', '" + row[1] + "', '" + row[2] + "')")
            except Exception as e:
                print(i, e)
            finally:
                i+=1


        con.commit()
        con.close()

    


if __name__ == '__main__':
    main()
