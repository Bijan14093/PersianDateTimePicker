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
            
            
 
 you can set time like
 
            pdtpFrom.TimPicker.Value = "00:00:00";
            pdtpTo.TimPicker.Value = "23:59:59";

for get value from control

                var FromDate = pdtpFrom.Value.ToString(); // Gregorian Date
                var PersianFromDate = pdtpFrom.Text; //Persian Date
                
