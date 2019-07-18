using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new composite(3);
            Component leftChild = new Leaf(8);
            Component rightChild = new composite(2);
            Component leftChildOfRightChild = new Leaf(5);
            Component rightChildOfRightChild = new Leaf(8);
            rightChild.AddChild(leftChildOfRightChild);
            rightChild.AddChild(rightChildOfRightChild);
            root.AddChild(leftChild);
            root.AddChild(rightChild);
            root.Draw("");
            Console.WriteLine(root.Sum());
            Console.WriteLine("is even: " + root.IsEven());

            Console.WriteLine("---------------------------------------");

            Component root2 = new composite(2);
            Component leftChild2 = new Leaf(8);
            Component rightChild2 = new composite(2);
            Component leftChildOfRightChild2 = new Leaf(4);
            Component rightChildOfRightChild2 = new Leaf(8);
            rightChild2.AddChild(leftChildOfRightChild2);
            rightChild2.AddChild(rightChildOfRightChild2);
            root2.AddChild(leftChild2);
            root2.AddChild(rightChild2);
            root2.Draw("");
            Console.WriteLine(root2.Sum());
            Console.WriteLine("is even: " + root2.IsEven());
        }

        static bool IsEven(Component biNonde)
        {
            return biNonde.IsEven();
        }
    }
}
