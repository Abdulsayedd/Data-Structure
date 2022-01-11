using System;
using System.Collections.Generic;
using System.Linq;

namespace Binary_Search_Tree
{ 
    public class node
    {
        public int data;
        public node left, right;
        public node(int d)
        {
            data = d;//data
            left=right=null;
        }
    }
    public class BinTree
    {
        node root;
        public BinTree()
        {
            root = null;
        }
          //=======================================\\
         //===================Add===================\\
        //===========================================\\
        public void add(int d)
        {
            root = add(root, d);
        }
        public node add(node root,int data)
        {
            if(root==null)
            {
                root = new node(data);//أول السجرة 
                return root;
            }
            else
            {
                if(data<root.data)//ريكرجن الشمال
                {
                    root.left= add(root.left, data); 
                }
                else if (data>root.data)//ريكرجن اليمين
                {
                    root.right = add(root.right, data);
                }
                return root;//رجع نود السجرة
            }
        }
          //=======================================\\
         //==================search=================\\
        //===========================================\\
        public node search(int d)
        {
            if (root == null || root.data == d)
                return root;

            if (d < root.data)
            { 
                root = root.left;
                return search(d);
            }
            else
            {
                root=root.right;
                return search(d);
            }
        }
          //=======================================\\
         //==================print==================\\
        //===========================================\\
        public void print_inorder()
        {
            Console.WriteLine("===InOrder===");
            print_inorder(root);//ننادي عشان نعرف نعمل ريكرجن
            Console.WriteLine();
        }
        public void print_inorder(node root)//نعمل ريكرجن
        {
            if (root != null)//شمال - اطبع - يمين
            {
                print_inorder(root.left);
                Console.Write(root.data + " ");
                print_inorder(root.right);
            }//اطبع بالترتيب
        }
        public void print_postorder()
        {
            Console.WriteLine("===PostOrder===");
            print_postorder(root);//ننادي عشان نعرف نعمل ريكرجن
            Console.WriteLine();
        }
        public void print_postorder(node root)//نعمل ريكرجن
        {
            if (root != null)//شمال - يمين - اطبع
            {
                print_inorder(root.left);
                print_inorder(root.right);
                Console.Write(root.data + " ");
            }
        }
        public void print_preorder()
        {
            Console.WriteLine("===PreOrder===");
            print_preorder(root);//ننادي عشان نعرف نعمل ريكرجن
            Console.WriteLine();
        }
        public void print_preorder(node root)//نعمل ريكرجن
        {
            if (root != null)//اطبع - شمال - يمين
            {
                Console.Write(root.data+" ");
                print_inorder(root.left);
                print_inorder(root.right);

            }
        }
          //=======================================\\
         //=================min,max=================\\
        //===========================================\\
        public void min()
        {
            min(root);
        }
        public node min(node root)
        {
            while (root.left != null)
            {
                root = root.left;
            }
            return root;
        }
        public void max()
        {
            max(root);
        }
        public node max(node root)
        {
            while (root.right != null)
            {
                root = root.right;
            }
            return root;
        }
        public void min_element()
        {
            min_element(root);
        }
        public void min_element(node root)
        {
            while (root.left != null)
            {
                root = root.left;
            }
            Console.WriteLine("Min element = " + root.data);
        }
        public void max_element()
        {
            max_element(root);
        }
        public void max_element(node root)
        {
            while (root.right != null)
            {
                root = root.right;
            }
            Console.WriteLine("Max element = " + root.data);
        }
          //=======================================\\
         //=================delete==================\\
        //===========================================\\
        public node delete(int d)
        {
            node p=root, parent=null, succ, parentsucc, child;
            // find the node, if exists 
            while (p != null)
            {
                if (d == p.data)
                    break;
                parent = p;
                if (d < parent.data)
                    p = p.left;
                else
                    p = p.right;
            }
            if (p == null)
            {
                Console.WriteLine("{0} not presented in the tree ", d);
                return root;
            }
            if (p.left != null && p.right != null)//if there is 2 childs -> left and right nodes exists ... taking the right as the root for deleted subtree
            {
                parentsucc = p;
                succ = p.right;
                while (succ.left != null)
                {
                    parentsucc = succ;
                    succ = succ.left;
                }
                p.data = succ.data;
                p = succ;
                parent = parentsucc;
            }
            // if there is 1 or no childs -> only left or right or neither exists 
            if (p.left != null) /*node to be deleted has left child */
                child = p.left;
            else                /*node to be deleted has right child or no child */
                child = p.right;

            if (parent == null)   /*node to be deleted is root node*/
                root = child;
            else if (p == parent.left)/*node is left child of its parent*/
                parent.left = child;
            else       /*node is right child of its parent*/
                parent.right = child;
            return root;

        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            BinTree b = new BinTree();
            b.add(10);
            b.add(41);
            b.add(25);
            b.add(6);
            b.add(2);
            b.add(71);
            b.add(3);
            b.add(5);
            b.add(21);
            b.add(33);
            b.print_inorder();
            b.print_postorder();
            b.print_preorder();
            b.min_element();
            b.max_element();
            Console.WriteLine("==");
            b.delete(33);
            b.print_inorder();
            b.print_postorder();
            b.print_preorder();//pre
        }
    }
}
