Console.WriteLine("-Troco-");

decimal ValorCobrar;
decimal ValorPago;
decimal ValorTroco;

Console.Write("Valor da Compra R$:");
ValorCobrar = Convert.ToDecimal(Console.ReadLine())!;

Console.Write("Valor Pago R$:");
ValorPago = Convert.ToDecimal(Console.ReadLine())!;

ValorTroco = ValorPago - ValorCobrar;

Console.WriteLine($"\ntroco: {ValorTroco:c}");