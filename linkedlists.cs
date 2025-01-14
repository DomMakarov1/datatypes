using System;

class Node {
  public string data;
  public Node next;

  public Node (string data) {
    this.data = data;
    this.next = null;
  }
}

class LinkedList {
  private Node head;

  public LinkedList() {
    head = null;
  }

  public void AddEnd(string data) {
    Node newNode = new Node(data);

    if (head == null) {
      head = newNode;
    } else {
      Node current = head;
      while (current.next != null) {
        current = current.next;
      }
      current.next = newNode;
    }
  }

  public void Traverse() {
    Node current = head;
    while (current != null) {
      Console.WriteLine(current.data + " -> ");
      current = current.next;
    }
    Console.WriteLine("null");
  }

  public bool Find(string data) {
    Node current = head;
    while (current != null) {
      if (current.data == data) return true;
    current = current.next;
    }
    return false;
  }

  public bool Delete(string data) {
    if (head == null) {
      return false;
    }

    if (head.data == data)
    {
      head = head.next;
      return true;
    }

    Node current = head;
    while (current != null && current.next != null) {
      if (current.next.data == data)
      {
        current.next = current.next.next;
        return true;
      }
      current = current.next;
    }

    return false;
  }
}

class Program {
  public static void Main (string[] args) {
    LinkedList list = new LinkedList();

    list.AddEnd("hey");
    list.AddEnd("you");
    list.AddEnd("there");

    list.Traverse();

    Console.WriteLine("Find you: " + list.Find("you"));
    Console.WriteLine("Find not: " + list.Find("not"));

    list.Delete("you");
    list.Traverse();
  }
}
