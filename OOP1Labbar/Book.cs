namespace OOP1Labbar
{
    class Book
    {
        private string title;
        private int countOfEx;
        private int borrowedCount;

        
        public string Title
        {
            get { return title; }
        }
        public int CountOfEx
        {
            get { return countOfEx;}
        }
        public int BorrowedCount
        {
            get { return borrowedCount;}
        }

        public void AddCountOfEx(int count)
        {
            countOfEx += count;
        }

        public Book(string title)
        {
            this.title = title;
            countOfEx = 0;
            borrowedCount = 0;
        }
        public bool TryBorrow()
        {
            if (borrowedCount >= countOfEx) return false;
            countOfEx++;
            return true;
        }
        public void Return()
        {
            if (borrowedCount > 0)
                borrowedCount--;
        }



        
    }







}
