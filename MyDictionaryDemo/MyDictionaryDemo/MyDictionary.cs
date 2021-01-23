using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryDemo
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] _key;  //TKey için gönderilen tür neyse o türde bir değişken oluşturduk
        TValue[] _value;

        TKey[] _tempKey;
        TValue[] _tempValue;
        public MyDictionary()
        {
            _key = new TKey[0]; // kendimiz oluşturuduğumuz için burada new leme işlemini yaptık yani 0 elemanlı bir dizi oluşturduk
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            _tempKey = _key;  // aşağıda dizi yeniden new lenince heap deki adresi (referans adresi) değişeceği için eski değerler kaybolmaması adına geçici diziye eşitledik
            _tempValue = _value;

            _key = new TKey[_key.Length + 1];  // diziye elemean ekleyebilmek için büyütme işlemini yaptık
            _value = new TValue[_value.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)  // yeni dizinin boşalan değerleri yerine eski değerleri atadık döngü ile
            {
                _key[i] = _tempKey[i];
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = key;  // add metotuna gelen parametre değişkenlerini burada dizinin yeni elemanı olarak ekledik
            _value[_value.Length - 1] = value;
            
        }

        public int Count  // "Liste" lerde olan "Count" özelliğini kendi yazdığımız bu koleksiyonda kullanabilmek için aynı isimde bir özellik oluşturduk
        {
            get
            {
                return _key.Length;  //dizinin uzunluğunu get ile okuyor ve döndürüyor
            }
        }

        public void GetAll()
        {
            for(int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine(_key[i] + ". ay : " + _value[i]);  // bu metot ile anahtar ve değerlerimizi yazdırıyoruz
            }
        }
    }

}
