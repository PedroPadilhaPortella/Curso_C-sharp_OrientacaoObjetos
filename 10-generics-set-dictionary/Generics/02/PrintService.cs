using System;

namespace _02
{
    class PrintService<PORTELLA>
    {
        private PORTELLA[] _value = new PORTELLA[10];
        private int _count = 0;
        public void AddValue(PORTELLA value) {
            if(_count == 10){
                throw new InvalidOperationException("PrintService is Full.");
            }
            _value[_count] = value;
            _count ++;
        }
        public PORTELLA First() {
            if(_count == 0){
                throw new InvalidOperationException("PrintService is Empty.");
            }
            return _value[0];
        }
        public void Print() {
            if(_value == null){
                throw new InvalidOperationException("PrintService is Empty.");
            }
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++){
                Console.Write(_value[i] + ", ");
            }
            if(_count > 0){
                Console.Write(_value[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}