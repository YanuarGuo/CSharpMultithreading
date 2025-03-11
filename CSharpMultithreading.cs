namespace CSharpMultithreading
{
    public partial class CSharpMultithreading : Form
    {
        public CSharpMultithreading()
        {
            InitializeComponent();
        }

        public void Threads()
        {
            LblThreading.Text = "Thread Start";
            Console.WriteLine("Thread Start");
            _ = new ThreadsClass();
            Thread threadA = new(new ThreadStart(ThreadsClass.Thread1));
            Thread threadB = new(new ThreadStart(ThreadsClass.Thread2));
            Thread threadC = new(new ThreadStart(ThreadsClass.Thread1));
            Thread threadD = new(new ThreadStart(ThreadsClass.Thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "ThreadA Process";

            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "ThreadB Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "ThreadC Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "ThreadD Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("Thread End");
            LblThreading.Text = "Thread End";
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            Threads();
        }
    }
}
