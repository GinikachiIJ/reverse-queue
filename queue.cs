public void Reverse(int k)  //queue is reversed based on it k given by the user
        {
            if (k > numItems)
            {
                MessageBox.Show("The queue contains less than k elements.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (k == 1)
            {
                return; 
            }

            // create a temporary stack to hold the first k elements of the queue
            Stack<Customer> stack = new Stack<Customer>();
            int count = 0;
            while (count < k)
            {
                stack.Push(Dequeue());
                count++;
            }

            // push the elements from the temporary stack back into the queue
            while (stack.Count > 0)
            {
                Enqueue(stack.Pop());
            }
        }
