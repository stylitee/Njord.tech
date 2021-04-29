using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalStaffManager.Class
{
    public class AllImportedAttendance
    {
        public int id { get; set; }
        public Employee empid { get; set; }
        public string date { get; set; }
        public string firstShiftIn { get; set; }
        public string firstShiftOut { get; set; }
        public string secondShiftIn { get; set; }
        public string secondShiftOut { get; set; }
        public string overtimeIn { get; set; }
        public string overtimeOut { get; set; }

        public void saveImportedFile(int id, string mydate, string firstIn, string firstOut, string SecondIn, string SecondOut, string overtimeIn, string overtimeOut)
        {
            AllImportedAttendance attendance = new AllImportedAttendance();
            attendance.date = mydate;
            attendance.firstShiftIn = firstIn;
            attendance.firstShiftOut = firstOut;
            attendance.secondShiftIn = SecondIn;
            attendance.secondShiftOut = SecondOut;
            attendance.overtimeIn = overtimeIn;
            attendance.overtimeOut = overtimeOut;

            ImportedAttendanceHelper.SaveImportedAttendance(attendance, id);

        }

        public void saveActualAttendance(int id, string mydate, string firstIn, string firstOut, string SecondIn, string SecondOut, string overtimeIn, string overtimeOut)
        {
            AllImportedAttendance attendance = new AllImportedAttendance();
            attendance.date = mydate;
            attendance.firstShiftIn = firstIn;
            attendance.firstShiftOut = firstOut;
            attendance.secondShiftIn = SecondIn;
            attendance.secondShiftOut = SecondOut;
            attendance.overtimeIn = overtimeIn;
            attendance.overtimeOut = overtimeOut;

            ImportedAttendanceHelper.SaveActualAttendance(attendance, id);

        }
    }
}
