#!/bin/env python3
import sys
import csv
import re

def main():
    with open('prod2.tsv', newline='') as tsvfile:
        reader = csv.reader(tsvfile, delimiter='	')
        data = []
        with open('new.csv', 'w') as csvfile:
            writer = csv.writer(csvfile)
            for row in reader:
                medicines = re.split(';|,', row[0])
                dosages = re.split(';|,', row[1])
                for med in medicines:
                    for dos in dosages:
                        writer.writerow([med.strip()]+[dos.strip()])
    


if __name__ == '__main__':
    main()
