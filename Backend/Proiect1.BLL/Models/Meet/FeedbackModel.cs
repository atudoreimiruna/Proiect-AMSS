﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect1.Services.Models.MeetModels
{
    public class FeedbackModel
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public int Rating { get; set; }
        public string FeedbackText { get; set; }
    }
}
