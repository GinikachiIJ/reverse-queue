
        private void button1_Click(object sender, EventArgs e)
        {
            int k = 0;

            if (!int.TryParse(textBox1EnterKvalue.Text, out k))
            {
                MessageBox.Show("Enter a valid integer k", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (k <= 0 || k > queue.Count)
            {
                MessageBox.Show("Invalid value of k. Please enter a value between 1 and the current count of customers in the queue.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            queue.Reverse(k);

            // Update the customerNameAge list box to show
            customerNameAge.Items.Clear();
            foreach (Customer customer in queue.Store)
            {
                if (customer != null)
                    customerNameAge.Items.Add($"Name: {customer.Name}, Age: {customer.Age}");
            }
        }
