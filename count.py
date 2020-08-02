Count = 0
Sum = 0
Avg = 0.0
Big = None
Small = None

print("Type Done To Show Results")
while True:
    print("Enter a Number")
    a = input()
    if a.lower() == "done":
        break
    Count += 1
    print(Count, "-", a)
    a2 = int(a)
    Sum += a2
    Avg = Sum / Count
    if Big is None or Big < a2:
        Big = a2
    if Small is None or Small > a2:
        Small = a2

print("The Count is -", Count)
print("The Sum is -", Sum)
print("The Average is -", Avg)
print("The Biggest Number is -", Big)
print("The Smallest Number is -", Small)

print("\nType Anything To Quit")
input()