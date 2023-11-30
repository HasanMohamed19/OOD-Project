///////////////////////////////////////////////////////////
//  Class.cs
//  Implementation of the Class Class
//  Generated by Enterprise Architect
//  Created on:      30-Nov-2023 11:07:25 AM
//  Original author: mohda
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace OOD_Project
{
    public enum WeekDays
    {
        sunday,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
    }


    public class Class
    {

        private DateTime beginDate;
        private string building;
        private int classId;
        private WeekDays dayOfTheWeek;
        private DateTime endTime;
        private DateTime finishDate;
        private string roomNumber;
        private DateTime startTime;
        public Section m_Section;



        public Class()
        {

        }

        ~Class()
        {

        }

        public DateTime BeginDate
        {
            get
            {
                return beginDate;
            }
            set
            {
                beginDate = value;
            }
        }

        public string Building
        {
            get
            {
                return building;
            }
            set
            {
                building = value;
            }
        }

        public int ClassId
        {
            get
            {
                return classId;
            }
            set
            {
                classId = value;
            }
        }

        public DateTime EndTime
        {
            get
            {
                return endTime;
            }
            set
            {
                endTime = value;
            }
        }

        public DateTime FinishDate
        {
            get
            {
                return finishDate;
            }
            set
            {
                finishDate = value;
            }
        }

        public string RoomNumber
        {
            get
            {
                return roomNumber;
            }
            set
            {
                roomNumber = value;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return startTime;
            }
            set
            {
                startTime = value;
            }
        }

        public WeekDays DayOfTheWeek { get => dayOfTheWeek; set => dayOfTheWeek = value; }
    }//end Class
}