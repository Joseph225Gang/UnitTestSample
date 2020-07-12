using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnitTest
{
    public class Day28_MultiThread
    {
        public Queue counterQue = new Queue();
        public bool status = false;     //var: correct = true. incorrect = false/
        public Thread thread;

        public Day28_MultiThread()
        {
            thread = new Thread(CompareNumbers);
        }

        public void RunUntilThreadComplete()
        {
            thread.Start();
        }

        public bool Equal2Times(int targetNumber, int testNumber)
        {
            if (targetNumber * 2 == testNumber)
                return true;
            else
                return false;
        }

     
        public void CompareNumbers()
        {
            while (true)
            {
                if (counterQue.Count > 0)
                {
                    int[] numberArray = (int[])counterQue.Dequeue();
                    status = Equal2Times(numberArray[0], numberArray[1]);
                }
            }
        }
    }
}
