﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Clock
{
    internal class EmployeeManager
    {
        private static string _loginSQL = "\t\r\ndeclare  @code int, @answer VARCHAR(250);\r\nIF exists (select * from Employees where id= @id)\r\n\tbegin\r\n\t\t--find the code from the exists employee\r\n\t\tselect @code = (select code from Employees where id=@id)\r\n\tend\r\nelse\r\n\tbegin\r\n\t\t\t-- הוספת עובד לטבלה\r\n\t\t\tINSERT into Employees values ( @id, @fullName);\r\n\t\t\tselect @code=@@IDENTITY;\r\n\t\tend\r\nIF exists (select * from Passwords WHERE employee_code=@code)\r\n\tbegin\r\n\t\tif exists (select password_string From Passwords\r\n\t\t\t\t\tWHERE employee_code=@code AND password_string=@password\r\n\t\t\t\t\tAND has_access=1 )\r\n\t\t\t\tbegin\r\n\t\t\t\t\tif exists (select password_string From Passwords\r\n\t\t\t\t\tWHERE employee_code=@code AND password_string=@password\r\n\t\t\t\t\tAND has_access=1 AND  password_expiry_date>=getdate())\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\tIF exists (SELECT * FROM Clock_Time\r\n\t\t\t\t\t\t\tWHERE employee_code=@code AND exit_time is null)\r\n\t\t\t\t\t\t\t\tbegin \t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\tUPDATE Clock_Time set exit_time=GETDATE()\r\n\t\t\t\t\t\t\t\t\tWHERE employee_code=@code AND exit_time is null;\r\n\t\t\t\t\t\t\t\t\tselect @answer='Exit time: ' + CONVERT (NVARCHAR, GETDATE(), 121);\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tINSERT INTO Clock_Time  VALUES (@code, GETDATE(), null);\r\n\t\t\t\t\t\t\t\tselect @answer='Entry time: ' + CONVERT (NVARCHAR, GETDATE(), 121);\r\n\t\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\tend\r\n\t\t\t\t\tELSE\r\n\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect @answer= 'you need to update your password';\r\n\t\t\t\t\t\tend\r\n\t\t\t\tend\r\n\t\tELSE\r\n\t\t\tbegin\r\n\t\t\tselect @answer = 'wrong password';\r\n\t\t\tend\r\n\tend\r\nELSE\r\n\tbegin\r\n\t\tINSERT INTO\tPasswords VALUES (@code, @password,\r\n\t\tDATEADD(day, 180, GETDATE()),\r\n\t\t1)\r\n\t\tselect @answer= 'You created a worker and password';\r\n\tend\r\n\r\n\tselect @answer\r\n\r\n";
        private static string _changePasswordSQL = "declare @code int, @answer varchar(250);\r\n\r\nIF exists (select * from Employees where id= @id)\r\n\tbegin\r\n\t\t--find the code from the exists employee\r\n\t\tselect @code = (select code from Employees where id=@id)\r\n\tend\r\nelse\r\n\tbegin\r\n\t\tselect @answer = 'Employee was not found!'\r\n\tend\r\n       if exists (select password_string From Passwords\r\n\t\t\tWHERE employee_code=@code AND password_string=@oldPass\r\n\t\t\tAND has_access=1)\r\n\t\t\tbegin\r\n\t\t\t\tif not exists (select password_string From Passwords\r\n\t\t\t\tWHERE employee_code=@code AND password_string=@newPass)\r\n\t\t\t\t\tbegin\t\t\t\t\t\t\r\n\t\t\t\t\t\tif @confirmPass=@newPass\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tupdate Passwords set has_access=0 where employee_code=@code AND password_string=@oldPass\r\n\t\t\t\t\t\t\t\tinsert into passwords values(@code, @newPass,\r\n\t\t\t\t\t\t\t\t\t\tDATEADD(day, 180, GETDATE()), 1)\r\n\t\t\t\t\t\t\t\t\t\tselect @answer = 'you have updated your password!'\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\t\telse\r\n\t\t\t\t\t\t\tbegin\r\n\t\t\t\t\t\t\t\tselect @answer = 'confirm password doesnt match new pasword!'\r\n\t\t\t\t\t\t\tend\r\n\t\t\t\t\tend\r\n\t\t\t\telse\r\n\t\t\t\t\tbegin\r\n\t\t\t\t\t\tselect answer = 'you already used this pasword!'\r\n\t\t\t\t\tend\r\n\t\t\tend\r\n\t\telse\r\n\t\t\tbegin\r\n\t\t\t\tselect @answer = 'current password in incorrect!'\r\n\t\t\tend\r\nselect @answer";
        
        public static string Login(string id, string password, string fuulname)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB    
            string[] parameters = { "@id", "@password", "@fullName" };
            string[] values = { id, password, fuulname };
            return DBConnection.runSQL(_loginSQL, parameters, values);
            // 3. Return response
        }
        public static string ChangePassword(string id, string oldPass, string newPass, string confirmPass)
        {
            // 1. Use the _loginSQL
            // 2. Execute SQL against DB
            // 3. Return response
            string[] parameters = { "@id", "@oldPass", "@newPass", "@confirmPass" };
            string[] values = { id, oldPass, newPass, confirmPass };
            return DBConnection.runSQL(_changePasswordSQL, parameters, values);
        }
    }
}
