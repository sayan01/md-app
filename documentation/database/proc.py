#!/bin/env python3
import sys
import sqlite3
import csv

def main():
    with open("procedures") as file:
        con = sqlite3.connect('data.db')
        cur = con.cursor()
        i = 0
        for row in file:
            try:
                cur.execute("INSERT INTO procedures(name) VALUES ('" + row.strip() + "')")
            except Exception as e:
                print(i, e)
            finally:
                i+=1


        con.commit()
        con.close()

    


if __name__ == '__main__':
    main()
