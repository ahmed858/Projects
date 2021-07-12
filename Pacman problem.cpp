/*     pacman game problem  */




#define _CRT_SECURE_NO_WARNINGS
#include<bits/stdc++.h>
#define ll				    long long
#define all(v)			    v.begin(),v.end()
#define allr(v)			    v.rbegin(),v.rend()
#define YES				    cout << "YES\n";
#define NO				    cout << "NO\n";
#define endl			    "\n"
#define vi				    vector<int>
#define vl				    vector<ll>
#define wach(x)			    cerr<<(#x)<<" = ("<<(x)<<")"<<"\n"
#define RT(v)			    return cout<<v,0
#define sz(x)			    x.size()
#define pii					pair<int,int>
#define MAX					1005
using namespace std;
const ll mod = 1e6;
const double EPS = 1e-10;
const double pi = 3.14159265358979323846;
const int Inf = 1e9;
//  down up right left  topright topleft bottomright bottomleft
int dx[] = { 1,-1,0,0 - 1,-1,1,1 };
int dy[] = { 0,0,-1,1 ,1,-1,1,-1 };
string dir[] = { "D","U","R","L" };
void fast() { 
//freopen("jumping.in", "r", stdin);
ios_base::sync_with_stdio(false); cin.tie(0); cout.tie(0);
}

int n = 0, m = 0,ans;
char grid[MAX+5][MAX+5];
bool valid(int i, int j) {
return i < n&& i >= 0 && j < m&& j >= 0;
}
int main()
{
	fast();

	pii start, goal;
	cin >> start.first >> start.second;
	cin >> goal.first >> goal.second;
	cin >> n >> m;
	for (int i = 0; i < n; i++)cin >> grid[i];
	map<pii, int>dis;
	queue<pii>Q;

	dis[start] = 0;
	Q.push(start);
	while (!Q.empty())
	{
		pii node = Q.front(); Q.pop();

		if (node == goal) {
			ans = dis[node];
			break;
		}
		int i = node.first;
		int j = node.second;
		if (!valid(i, j))continue;
		if (grid[i][j] == '%')continue; // % simulate walls
		vector < pii > neighbors = { {i - 1,j},{i + 1,j},{i ,j - 1},{i ,j + 1} }; // child to cur node (postion)

		for (pii child : neighbors) if (dis.find(child) == dis.end()) {
			dis[child] = dis[node] + 1;
			Q.push(child);
		}
	}
	cout << ans << endl;
  return 0;
}



