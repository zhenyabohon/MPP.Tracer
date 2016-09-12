﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR.Mishin.Tracer {
    interface ITracer {
        void Start();
        List<Tracer.TracerThreadTree> Stop();

        void StartTrace();
        void StopTrace();
    }
}
