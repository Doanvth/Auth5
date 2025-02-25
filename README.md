# Auth5
# code sinh SecretKey JWT 
#  using (var rng = new RNGCryptoServiceProvider())
# {
#     byte[] key = new byte[32]; 	
#     rng.GetBytes(key);
#    string secretKey = Convert.ToBase64String(key);
#     Console.WriteLine("SecretKey: " + secretKey);
#    Console.ReadKey();
# }