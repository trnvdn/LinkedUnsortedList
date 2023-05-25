namespace LinkedUnsortedList;

public class Solution
{
    private Node? _head;

        public void AddItem(int num)
        {
            if (_head == null)
            {
                _head = new Node(num);
            }
            else
            {
                Node? list = _head;
                Node current = new Node(num);
                current.Value = num;
                while (list!.Next != null)
                {
                    list = list.Next;
                }

                list.Next = current;
            }
        }

        public void PrintAll()
        {
            if (_head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            Node? current = _head;

            while (current != null)
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }

            Console.WriteLine();
        }

        public void BubleSort()
        { 
            bubbleSort();
            PrintAll();
        }
        private Node bubbleSort()
        {
            if (_head == null || _head.Next == null)
                return _head;

            bool swapped;
            do
            {
                swapped = false;
                Node previous = null;
                Node current = _head;

                while (current.Next != null)
                {
                    if (current.Value > current.Next.Value)
                    {
                        Node nextNode = current.Next;
                        Node temp = nextNode.Next;

                        if (previous == null)
                            _head = nextNode;
                        else
                            previous.Next = nextNode;

                        nextNode.Next = current;
                        current.Next = temp;

                        current = nextNode;
                        swapped = true;
                    }

                    previous = current;
                    current = current.Next;
                }
            } while (swapped);

            return _head;
        }
}