def GetEmpInfo():
    empname = input("Enter employee name: ")
    hours   =   int(input ("Enter number of hours worked: "))
    payrate = float(input ("Enter hourly rate: "))
    return empname, hours, payrate

def CalcWeeklyPay(hours, payrate):
    return hours * payrate


if__name__ == "__main__":
    #main()
    empname, hours, payrate = GetEmpInfo()
    print(empname)
    print(hours)
    print(payrate)
    weeklypay = CalcWeeklyPay(hours, payrate)
    print(weeklypay)
    print(CalcWeeklyPay(hours,payrate))

