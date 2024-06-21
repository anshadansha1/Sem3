#Function to calculate Bill
def billCalculator(cUnits):
    if cUnits <= 200:
        bill = cUnits * 0.50
    elif cUnits <= 400:
        bill = (200 * 0.50) + (cUnits -200) * 0.65
    elif cUnits <= 600:
        bill = (200 * 0.50) + (200 * 0.65) + (cUnits - 400) * 0.80
    else:
        bill = (200 * 0.50) + (200 * 0.65) + (200 * 0.80) + (cUnits - 600) * 1.00 
    
    #Add surcharge to bill if bill amount > 400     
    if bill > 400 :
        surCharge = (bill - 400) * 0.15
        bill += surCharge
    
    #If bill < 100 Make bill as 100 
    if bill < 100 :
        bill = 100

    return bill


print("\nProgram to calculate electric power consumption -->\n")

consumedUnits = float(input("\nEnter the units consumed : "))

totalBill = billCalculator(consumedUnits)
print(f"Total Bill : Rs. {totalBill}")

