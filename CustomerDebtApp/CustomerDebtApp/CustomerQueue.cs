using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.AxHost;

namespace CustomerDebtApp
{
    internal class CustomerQueue
    {
        private readonly int maxsize = 10;
        private Customer[] customers;
        private int tail = 0;
        private int head = 0;
        private int countCustomer = 0;

        public CustomerQueue()
        {
            customers = new Customer[maxsize];
        }
        public CustomerQueue(int size)
        {
            maxsize = size;
            customers = new Customer[maxsize];
        }
        public void Enqueue(string name, int age, string address, float amountOwed)
        {
            Customer create_customer = new Customer(name, age, address, amountOwed);
            customers[tail] = create_customer;
            tail++;
            //tail = tail + 1;
            countCustomer++;

            if (tail == maxsize)
            {
                tail = 0;

            }



        }
        public Customer Dequeue()
        {
            Customer remove_customer = customers[head];
            head++;
            //head = head + 1;
            countCustomer--;

            return remove_customer;
        }
        public int Count()
        {
            return countCustomer;
        }

        public Customer Peek()
        {
            return customers[head];
        }

        public bool IsEmpty()
        {
            return countCustomer == 0;
        }

        public bool IsFull()
        {
            return countCustomer == maxsize;
        }

        public string Display()
        {
            StringBuilder output = new StringBuilder();
            for (int i = head; i <= tail -1 ; i++)
            {
                output.AppendLine(customers[i].GetInformation() + ","); // Get string representation of customer
            }
            return output.ToString();


        }
    }


}
