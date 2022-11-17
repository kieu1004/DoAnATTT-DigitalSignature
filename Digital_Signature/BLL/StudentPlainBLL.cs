﻿using Digital_Signature.DAL;
using Digital_Signature.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_Signature.BLL
{
    internal class StudentPlainBLL
    {
        public static bool addNewStudent(StudentPlainDTO studentPlain)
        {
            return StudentPlainDAL.addNewStudent(studentPlain);
        }
        public static List<StudentPlainDTO> getStudentsSigned(int userId)
        {
            return StudentPlainDAL.getStudentsSigned(userId);
        }
    }
}
