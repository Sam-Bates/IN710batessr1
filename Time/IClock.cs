﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    interface IClock
    {
        void updateClock();
        void show();
        void hide();
    }
}