using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyStack
{
    //creating the custom stack class
    public class CustomStack<Type>
    {
        //setting the private field _top to get the top  element
        private int _top;
        //setting the private field _capacity to get the capacity of the elements
        private int _capacity;
        //creating the getter to get the top element
        public int Top
        {
            get
            {
                return _top;
            }
        }
        // creting the getter to get the count of the elements
        public int Count
        {
            get
            {
                return _top + 1;
            }
        }
        // creating a private array to store the values
        private Type[] _array; 
        //creating the default constructor to create an instance without the parameter
        public CustomStack(){
            _top=-1;
            _capacity=4;
            _array=new Type[_capacity];
        }
        // creating the parameterized constructor to create an instance with the parameter value
        public CustomStack(int size){
            _top=-1;
            _capacity =size;
            _array=new Type[_capacity];
        }
        //Push method is used to add the elements in the array
        public void Push(Type element){
            if(Count ==_capacity){
             GrowSize();
            }
            _array[_top+1]=element;
            _top++;
        }
        // GrowSize method is used to grow the capacity of the array when it reaches the maximum capacity 
        void GrowSize(){
            _capacity*=2;
            Type[] temp = new Type[_capacity];
            for (int i=0;i<Count;i++){
                temp[i]=_array[i];
            } 
            _array=temp;
        }
        //Peek method is used to get the last inserted value in the stack
        public Type Peek(){
            if(_top==-1){
                return default(Type);
            }
            else{
                return _array[_top];
            }
        }
        //Pop method remove and return the last inserted value in a array
        public Type Pop(){
            if(_top ==-1){
                return default(Type);
            }
            else{
                _top--;
                return _array[_top+1];
            }
        }
    }
}