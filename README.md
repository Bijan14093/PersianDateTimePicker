# PersianDateTimePicker

this control only used for .net windows application.

# Installation

dotnet add package PersianDateTimeControl

---

After installation, you will see three controls in the toolbox in visual studio IDE.

1. PersianDatePicker
2. PersianDateTimePicker
3. PersianTimePicker

drag one of control that you need.

for example :
 I drag PersianDateTimePicker and rename it to pdtpFrom.
 
 if you want to set control to current date.
 
            pdtpFrom.DatePicker.Value = DateTime.Now;
            pdtpFrom.TimPicker.Value = DateTime.Now.ToString("HH:MM:ss");
            
            
 


