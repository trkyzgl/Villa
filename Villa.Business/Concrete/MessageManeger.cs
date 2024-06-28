﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Business.Abstract;
using Villa.DataAccess.Abstract;
using Villa.Entity.Entities;

namespace Villa.Business.Concrete
{
    public class MessageManeger : GenericManager<Message>, IMessageService
    {
        public MessageManeger(IGenericDal<Message> genericDal) : base(genericDal)
        {
        }
    }
}