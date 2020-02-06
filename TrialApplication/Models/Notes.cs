﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrialApplication.Models
{
    public class Notes
    {

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }

    }
}
