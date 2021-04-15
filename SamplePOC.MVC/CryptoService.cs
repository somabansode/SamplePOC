 private const string HASHKEY = "1B96EBCA-412F-44b9-8079-B204E1253DA6";
        public static string Encrypt(string data) {
            if (string.IsNullOrEmpty(data)) {
                throw new ArgumentNullException(nameof(data));
            }
            var rijndaelManaged = new RijndaelManaged() {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 0x80,
                BlockSize = 0x80,
            };
            byte[] passBytes = Encoding.UTF8.GetBytes(HASHKEY);
            byte[] encryptionkeyBytes = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
            int len = passBytes.Length;
            if (len > encryptionkeyBytes.Length) {
                len = encryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, encryptionkeyBytes, len);
            rijndaelManaged.Key = encryptionkeyBytes;
            rijndaelManaged.IV = encryptionkeyBytes;
            ICryptoTransform objtransform = rijndaelManaged.CreateEncryptor();
            byte[] textDataByte = Encoding.UTF8.GetBytes(data);
            return Convert.ToBase64String(objtransform.TransformFinalBlock(textDataByte, 0, textDataByte.Length));
        }
        public static string Decrypt(string data) {
            if (string.IsNullOrEmpty(data)) {
                throw new ArgumentNullException(nameof(data));
            }
            var rijndaelManaged = new RijndaelManaged() {
                Mode = CipherMode.CBC,
                Padding = PaddingMode.PKCS7,
                KeySize = 0x80,
                BlockSize = 0x80,
            };
            byte[] encryptedTextByte = Convert.FromBase64String(data);
            byte[] passBytes = Encoding.UTF8.GetBytes(HASHKEY);
            byte[] encryptionkeyBytes = new byte[0x10];
            int len = passBytes.Length;
            if (len > encryptionkeyBytes.Length) {
                len = encryptionkeyBytes.Length;
            }
            Array.Copy(passBytes, encryptionkeyBytes, len);
            rijndaelManaged.Key = encryptionkeyBytes;
            rijndaelManaged.IV = encryptionkeyBytes;
            byte[] textByte = rijndaelManaged.CreateDecryptor().TransformFinalBlock(encryptedTextByte, 0, encryptedTextByte.Length);
            return Encoding.UTF8.GetString(textByte);  // it will return readable string
        }
