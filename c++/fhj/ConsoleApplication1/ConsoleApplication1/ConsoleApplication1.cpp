#include <Windows.h>

LRESULT CALLBACK WndProc(HWND, UINT, WPARAM, LPARAM);
HWND hwnd;
int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE hPrevInstance, PSTR cmdLine, int cmdShow) {
    ​​​​


        WNDCLASSEX wndclass;
    wndclass.cbSize = sizeof(wndclass);
    wndclass.lpszClassName = L"Моя первая программа";
    wndclass.style = CS_HREDRAW | CS_VREDRAW;
    wndclass.hInstance = hInstance;
    wndclass.lpfnWndProc = WndProc;
    wndclass.cbClsExtra = 0;
    wndclass.cbWndExtra = 0;
    wndclass.hIcon = LoadIcon(NULL, IDI_APPLICATION); //дефолтная иконка
    wndclass.hCursor = LoadCursor(NULL, IDC_ARROW); //дефолтный курсор
    wndclass.hbrBackground = (HBRUSH)GetStockObject(WHITE_BRUSH);
    wndclass.lpszMenuName = NULL;
    wndclass.hIconSm = LoadIcon(NULL, IDI_APPLICATION);

    RegisterClassEx(&wndclass);

    hwnd = CreateWindowEx(
        WS_EX_OVERLAPPEDWINDOW | WS_EX_TOPMOST,
        L"Моя первая программа",
        L"Бла-Бла v 1.0.1",
        WS_BORDER | WS_TILEDWINDOW,
        CW_USEDEFAULT,
        CW_USEDEFAULT,
        800,
        600,
        NULL,
        NULL,
        hInstance,
        NULL
    );
    ShowWindow(hwnd, cmdShow);
    UpdateWindow(hwnd);

    MSG msg;
    while (GetMessage(&msg, NULL, 0, 0)) {
        ​​​​
            TranslateMessage(&msg);
        DispatchMessage(&msg);
    }​​​​

        return msg.wParam;
}​​​​

LRESULT CALLBACK WndProc(HWND hwnd, UINT iMsg, WPARAM wParam, LPARAM lParam) {
    ​​​​
        switch (iMsg)
        {
            ​​​​case WM_DESTROY:
            PostQuitMessage(0);
            break;

        }​​​​
            return DefWindowProc(hwnd, iMsg, wParam, lParam);
}​​​​