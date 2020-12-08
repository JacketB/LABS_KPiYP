using System;

using System.IO;

namespace Prim

{

class Program

{

static void Main(string[] args)

{

StreamReader fsRead = File.OpenText("input.txt");

int n = Convert.ToInt32(fsRead.ReadLine());

const int INF = 1000000000;

int[,] g = new int[n, n];

bool[] used = new bool[n];

int[] min_e = new int[n];

for (int i = 0; i < n; i++)

min_e[i] = INF;

int[] sel_e = new int[n];

for (int i = 0; i < n; i++)

sel_e[i] = -1;

min_e[0] = 0;

for (int i = 0; i < n; i++)

{

for (int j = 0; j < n; j++)

{

int temp = Convert.ToInt32(fsRead.ReadLine());

if (temp == -1)

g[i, j] = INF;

else

g[i, j] = temp;

}

}

fsRead.Close();

for (int i = 0; i < n; ++i)

{

int v = -1;

for (int j = 0; j < n; ++j)

if (!used[j] && (v == -1 || min_e[j] < min_e[v]))

v = j;

if (min_e[v] == INF)

{

Console.WriteLine("No MST!");

return;

}

used[v] = true;

if (sel_e[v] != -1)

Console.WriteLine((v+1).ToString() + " " + (sel_e[v]+1).ToString() + "\n");

for (int to = 0; to < n; ++to)

if (g[v,to] < min_e[to])

{

min_e[to] = g[v,to];

sel_e[to] = v;

}

}

Console.ReadKey();

}

}

}