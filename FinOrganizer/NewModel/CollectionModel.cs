using System;
using System.Collections;
using System.Collections.Generic;

namespace FinOrganizer 
{
    public class CollectionModel : IDataModel
    {
        private int currentSum;
        public int CurrentSum
        {
            get
            {
                return currentSum;
            }

            set
            {
                currentSum += value;
            }
        }

        List<Operation> list = new List<Operation>();
                
        public CollectionModel()
        {
            list.Add(new Operation()
            {
                sign = true,
                cost = 450,
                date = DateTime.Now.Date
            });

            list.Add(new Operation()
            {
                sign = true,
                cost = 500,
                date = DateTime.Now.Date
            });
        }

        

        public void put(Operation o)
        {
            list.Add(o);
            CurrentSum = o.cost;
        }

        

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }

    public struct Operation
    {
        public bool sign;
        public int cost;

        public DateTime date;
    }
}



