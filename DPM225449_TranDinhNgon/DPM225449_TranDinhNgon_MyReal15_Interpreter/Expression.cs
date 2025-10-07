using DPM225449_TranDinhNgon_MyReal15_Interpreter;

public abstract class Expression
{
    public void Interpret(Context context)
    {
        if (string.IsNullOrEmpty(context.Input))
            return;

        // Tìm số đứng trước ký hiệu
        for (int i = 0; i < context.Input.Length; i++)
        {
            if (char.IsDigit(context.Input[i]))
            {
                continue;
            }

            // Khi gặp ký tự chữ, lấy số trước nó
            string numberStr = context.Input.Substring(0, i);
            double number = double.Parse(numberStr);

            if (context.Input[i].ToString() == Symbol())
            {
                context.Output += number * Multiplier();
                // cắt bỏ phần đã xử lý
                context.Input = context.Input.Substring(i + 1);
                // reset vòng lặp
                i = -1;
            }
        }
    }

    public abstract string Symbol();     // Ký hiệu (B, M, K)
    public abstract double Multiplier(); // Hệ số nhân
}