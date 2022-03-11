﻿using GameDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    interface IGameService
    {
        public void Add(Game game);
        public void Delete(Game game);
        public void Update(Game game, string version);

    }
}
