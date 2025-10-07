using System;

namespace DPM225449_TranDinhNgon_MyReal17_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            SupportCenter center = new SupportCenter();

            User alice = new Customer("Alice");
            User bob = new Customer("Bob");
            User agent1 = new SupportAgent("Agent1");
            User agent2 = new SupportAgent("Agent2");

            center.Register(alice);
            center.Register(bob);
            center.Register(agent1);
            center.Register(agent2);

            alice.Send("Agent1", "Tôi cần hỗ trợ về sản phẩm.");
            agent1.Send("Alice", "Chào Alice, tôi có thể giúp gì cho bạn?");
            bob.Send("Agent2", "Tôi gặp lỗi khi đăng nhập.");
            agent2.Send("Bob", "Bạn vui lòng cung cấp thêm thông tin lỗi.");

            Console.ReadKey();
        }
    }

    
}
