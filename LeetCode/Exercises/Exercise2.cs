using System.Numerics;

namespace LeetCode.Exercises;

public class Exercise2() : Exercise(2)
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        BigInteger l1Value = GetNumber(l1, 0, 1);
        BigInteger l2Value = GetNumber(l2, 0, 1);

        BigInteger result = l1Value + l2Value;

        var mainNode = new ListNode();

        return NumberToListNode(result, mainNode);
    }

    public BigInteger GetNumber(ListNode? node, BigInteger result, BigInteger multiple)
    {
        if (node is not null)
        {
            BigInteger cacheValue = node.val * multiple;
            return GetNumber(node.next, (BigInteger)result + cacheValue, (BigInteger)multiple * 10);
        }

        return result;
    }

    public ListNode NumberToListNode(BigInteger val, ListNode mainNode)
    {
        BigInteger lastDigit = val % 10;
        BigInteger newValue = val / 10;

        mainNode.val = (int)lastDigit;

        if (newValue > 0)
        {
            mainNode.next = new ListNode();

            NumberToTmpListNode(newValue, mainNode.next);
        }

        return mainNode;
    }

    public ListNode NumberToTmpListNode(BigInteger val, ListNode tmpNode)
    {
        if (val > 9)
        {
            BigInteger lastDigit = val % 10;
            BigInteger newValue = val / 10;

            tmpNode.val = (int)lastDigit;
            tmpNode.next = new ListNode();
            return NumberToTmpListNode(newValue, tmpNode.next);
        }

        if (val > 0)
        {
            int lastDigit = (int)val % 10;
            BigInteger newValue = val / 10;

            tmpNode.val = lastDigit;
            return NumberToTmpListNode(newValue, null);
        }

        return tmpNode;
    }

    public static ListNode CreateLinkedList(int[] arr)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        foreach (int num in arr)
        {
            current.next = new ListNode(num);
            current = current.next;
        }

        return dummy.next;
    }

    public override void Print()
    {
        base.Print();

        var node1 = new ListNode() { val = 2, next = new ListNode() { val = 4, next = new ListNode(3) } };
        var node2 = new ListNode() { val = 5, next = new ListNode() { val = 6, next = new ListNode(4) } };

        var node11 = new ListNode() { val = 0 };
        var node12 = new ListNode() { val = 0 };

        var node21 = CreateLinkedList([
            1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1
        ]);
        var node22 = CreateLinkedList([5, 6, 4]);

        var node = AddTwoNumbers(node21, node22);
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}