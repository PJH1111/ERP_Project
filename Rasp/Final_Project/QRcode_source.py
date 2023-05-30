import pygame, pygame_gui, requests
import cv2, numpy as np
from pyzbar.pyzbar import decode
from datetime import datetime
from PIL import Image
from img_encode import Img_encode
from create_qr import Create_qr
from button import Button
from button import ImgButton

url = 'http://13.209.6.6:8080'

pygame.init()
pygame.font.init()
clock = pygame.time.Clock() 
time_delta = clock.tick(60) / 1000.0 # 게임 화면의 초당 프레임 수를 결정
font_30 = pygame.font.SysFont(None, 30, False, False)
font_40 = pygame.font.SysFont(None, 40, False, False)

WIDTH = 780
HEIGHT = 450
WHITE = (255,255,255)
myColor = (33,40,45)

def start():
    pygame.init()
    screen = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("Welcome")
    screen.fill((myColor))
    manager = pygame_gui.UIManager((WIDTH, HEIGHT)) # UI 매니저 생성
    
    R_button = Button('Registration',200,150,(120, 170),5)
    W_button = Button('Work/Leave',200,150,(490, 170),5)
    exit_img = pygame.image.load('exit.bmp').convert_alpha()
    new_size = (exit_img.get_width() // 10, exit_img.get_height() // 10)
    exit_img = pygame.transform.scale(exit_img, new_size)
    exit_button = ImgButton(739, 0, exit_img, 0.8)
    
    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                    running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if event.button == 1:
                    if exit_button.rect.collidepoint(event.pos):
                        running = False
            manager.process_events(event) # UI 매니저에 이벤트 전달
        R_button.check_click()
        if R_button.pressed and R_button.top_rect.y == R_button.original_y_pos:
            login()
        W_button.check_click()
        if W_button.pressed and W_button.top_rect.y == W_button.original_y_pos:
            working()
            
        manager.update(time_delta) # UI 매니저 업데이트
        R_button.draw(screen)
        W_button.draw(screen)
        exit_button.draw(screen)
        manager.draw_ui(screen)
        pygame.display.flip()   
    pygame.quit()

def error_login():
    pygame.init()
    error_login = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("Fail")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    
    text_check = font_30.render("Login is Fail..", True, WHITE)
    text_nice = font_30.render("Please log in again!", True, WHITE)
    ok_button = pygame_gui.elements.UIButton(
        relative_rect=pygame.Rect((370, 240), (50, 30)),
        text='OK',
        manager=manager,
    )
    home_img = pygame.image.load('home3.bmp').convert_alpha()
    new_size = (home_img.get_width() // 12, home_img.get_height() // 12)
    home_img = pygame.transform.scale(home_img, new_size)
    home_button = ImgButton(745, 0, home_img, 0.8)
    error_img = pygame.image.load('error.bmp')
    size = (home_img.get_width() // 2+80, home_img.get_height() // 2+80)
    error_img = pygame.transform.scale(error_img, size)
    
    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if event.button == 1:
                    if home_button.rect.collidepoint(event.pos):
                        start()
            elif event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == ok_button:
                        login()
                        
            manager.process_events(event)
        error_login.fill((myColor))
        error_login.blit(error_img, (485, 100))
        error_login.blit(text_check, (330, 180))
        error_login.blit(text_nice, (300, 210))
        manager.update(time_delta)
        manager.draw_ui(error_login)
        home_button.draw(error_login)
        pygame.display.flip()
    pygame.quit()

def loadqr(qrname):
    pygame.init()
    loadqr = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("QR Code")
    
    # 타이머 설정
    timer = 10000  # 10초를 밀리초로 환산한 값
    start_ticks = pygame.time.get_ticks()  
    
    image_surface = pygame.image.load(qrname)
    font = pygame.font.SysFont(None, 30, 0.1)
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    text_timer = font_30.render("Automatically returns to the home screen after the time limit!", True, WHITE)
    home_img = pygame.image.load('home3.bmp').convert_alpha()
    new_size = (home_img.get_width() // 12, home_img.get_height() // 12)
    home_img = pygame.transform.scale(home_img, new_size)
    home_button = ImgButton(745, 0, home_img, 0.8)
    
    running = True
    while running:
        # 타이머 갱신
        timer_label = font.render('00 : 0' + str(int((timer - pygame.time.get_ticks() + start_ticks)/1000)) + ' sec', True, WHITE)
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if event.button == 1:
                    if home_button.rect.collidepoint(event.pos):
                        start()
            manager.process_events(event)
        if pygame.time.get_ticks() - start_ticks >= timer:
            start()  
        loadqr.fill((myColor))
        loadqr.blit(image_surface, (240, 100))
        loadqr.blit(text_timer, (100, 40))
        loadqr.blit(timer_label, (340, 70))
        manager.update(time_delta)
        manager.draw_ui(loadqr)
        home_button.draw(loadqr)
        pygame.display.flip()
    pygame.quit()

def login():
    pygame.init()
    login = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("Login")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    login.fill((myColor))
    
    window = pygame_gui.elements.UIWindow(
        rect=pygame.Rect((0, 0), (WIDTH, HEIGHT)),
        manager=manager,
        window_display_title="Login",
    )    
    username_label = pygame_gui.elements.UILabel(
        relative_rect=pygame.Rect((30, 140), (30, 40)),
        text='ID :',
        manager=manager,
        container=window,
    )
    username_textbox = pygame_gui.elements.UITextEntryLine(
        relative_rect=pygame.Rect((70, 140), (250, 40)),
        manager=manager,
        container=window,
    )  
    password_label = pygame_gui.elements.UILabel(
        relative_rect=pygame.Rect((30, 190), (30, 40)),
        text='PW :',
        manager=manager,
        container=window,
    )
    password_textbox = pygame_gui.elements.UITextEntryLine(
        relative_rect=pygame.Rect((70, 190), (250, 40)),
        manager=manager,
        container=window,
        object_id='password_textbox'
    )
    login_button = pygame_gui.elements.UIButton(
        relative_rect=pygame.Rect((140, 250), (100, 50)),
        text='Login',
        manager=manager,
        container=window,
    )
    BUTTONS = []
    for i, text in enumerate(['7', '8', '9', '4', '5', '6', '1', '2', '3', '0', '.', '←']):
        BUTTONS.append(
            pygame_gui.elements.UIButton(
                relative_rect=pygame.Rect((400 + (i % 3) * 115, 30 + (i // 3) * 90), (100, 80)),
                text=text,
                manager=manager,
                container=window,
            )
        )
    home_img = pygame.image.load('home22.bmp').convert_alpha()
    new_size = (home_img.get_width() // 12, home_img.get_height() // 12)
    home_img = pygame.transform.scale(home_img, new_size)
    home_button = ImgButton(15, 41, home_img, 0.8)
    
    running = True
    selected_textbox = None
    selectPassWord = False
    password = ""
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if event.button == 1:
                    if home_button.rect.collidepoint(event.pos):
                        start()
            global username 
            username = username_textbox.text
            if event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element in BUTTONS:
                        if selected_textbox:  # 선택된 텍스트박스가 있으면
                            if selected_textbox == password_textbox:
                                selectPassWord = True
                            else:
                                selectPassWord = False
                            button_text = event.ui_element.text
                            if button_text != '←':
                                if selectPassWord:
                                    password += button_text
                                    selected_textbox.set_text('*' * len(password))
                                else:   
                                    selected_textbox.set_text(selected_textbox.text + button_text)  # 선택된 텍스트박스에만 text값을 추가
                            else:
                                if selectPassWord:
                                    password = password[:-1]
                                    selected_textbox.set_text('*' * len(password))
                                else:
                                    selected_textbox.set_text(selected_textbox.text[:-1])  # 선택된 텍스트박스에서 한 글자 삭제
                    elif event.user_type == pygame_gui.UI_WINDOW_CLOSE:
                        if event.ui_element == window:
                            start()
                    elif event.ui_element == login_button:
                        url_ReadInfo = url+ '/ReadInfo'
                        params = {
                            'employeeNumber': username,
                            'PW': password
                        }
                        response = requests.get(url_ReadInfo, params=params)
                        result = response.json()
                        print(result)
                        if response.status_code != 200:
                            error_login()
                        else:
                            url_Updateqr = url + '/Updateqr'
                            headers = {'Content-Type' : 'application/json'}
                            data = {
                                'employeeNumber': username,
                                'qrcode': Img_encode(Create_qr(username)),
                            }
                            response = requests.post(url_Updateqr, headers=headers, json=data)
                            qr_image = Image.open(Create_qr(username))
                            qrname = username + '.bmp'
                            qr_image.save(qrname)
                            loadqr(qrname)
            if event.type == pygame.MOUSEBUTTONDOWN:
                # 클릭한 위치가 어떤 텍스트박스 안에 있는지 확인
                mouse_pos = event.pos
                if username_textbox.rect.collidepoint(mouse_pos):
                    selected_textbox = username_textbox
                elif password_textbox.rect.collidepoint(mouse_pos):
                    selected_textbox = password_textbox
            manager.process_events(event)
        manager.update(time_delta)
        manager.draw_ui(login)
        home_button.draw(login)
        pygame.display.flip()
    pygame.quit()

def check_qr():
    pygame.init()
    check_qr = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("OK")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    check_qr.fill((myColor))
    
    text_check = font_40.render("QR code confirmed.", True, WHITE)
    text_nice = font_40.render("Have a nice day!", True, WHITE)
    ok_button = pygame_gui.elements.UIButton(
        relative_rect=pygame.Rect((433, 240), (60, 30)),
        text='OK',
        manager=manager,
    )
    home_img = pygame.image.load('home3.bmp').convert_alpha()
    new_size = (home_img.get_width() // 12, home_img.get_height() // 12)
    home_img = pygame.transform.scale(home_img, new_size)
    home_button = ImgButton(745, 0, home_img, 0.8)
    qr_img = pygame.image.load('qr2.bmp')
    size = (qr_img.get_width() // 2, qr_img.get_height() // 2)
    qr_img = pygame.transform.scale(qr_img, size)

    running = True
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if event.button == 1:
                    if home_button.rect.collidepoint(event.pos):
                        start()
            elif event.type == pygame.USEREVENT:
                if event.user_type == pygame_gui.UI_BUTTON_PRESSED:
                    if event.ui_element == ok_button:
                        start()
            manager.process_events(event)
        check_qr.blit(qr_img, (180, 155))
        check_qr.blit(text_check, (350, 160))
        check_qr.blit(text_nice, (350, 200))
        manager.update(time_delta)
        manager.draw_ui(check_qr)
        home_button.draw(check_qr)
        pygame.display.flip()
    pygame.quit()
    
def working():
    now = datetime.now()
    Date = int(now.date().strftime("%Y%m%d"))
    Time = int(now.time().strftime("%H%M%S"))
    checkQr = False
    pygame.init()
    working = pygame.display.set_mode((WIDTH, HEIGHT))
    pygame.display.set_caption("QR Code Reader")
    manager = pygame_gui.UIManager((WIDTH, HEIGHT))
    font = pygame.font.SysFont(None, 30, 0.05)

    cap = cv2.VideoCapture(0)
    cap.set(cv2.CAP_PROP_FRAME_WIDTH, 620)
    cap.set(cv2.CAP_PROP_FRAME_HEIGHT, 380)
    employeeNumber = None
    text_check = font_30.render("Please recognize the QR code!", True, WHITE)
    home_img = pygame.image.load('home3.bmp').convert_alpha()
    new_size = (home_img.get_width() // 12, home_img.get_height() // 12)
    home_img = pygame.transform.scale(home_img, new_size)
    home_button = ImgButton(745, 0, home_img, 0.8)

    timer = 10000 
    start_ticks = pygame.time.get_ticks()
    running = True
    while running:  
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False
            elif event.type == pygame.MOUSEBUTTONDOWN:
                if event.button == 1:
                    if home_button.rect.collidepoint(event.pos):
                        cap.release()
                        start()
            manager.process_events(event)  
            if pygame.time.get_ticks() - start_ticks >= timer:
                cap.release()
                start()
        timer_label = font.render('00 : ' + str(int((timer - pygame.time.get_ticks() + start_ticks)/1000)) + ' sec', True, WHITE)
        ret, frame = cap.read()
        if ret:
            decoded_objs = decode(frame) # QR 코드 디코딩
            frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)
            frame = np.rot90(frame)
            frame = np.flip(frame, axis=0)
            frame = pygame.surfarray.make_surface(frame)
            try:
                for obj in decoded_objs:
                    print("Data:", obj.data) # QR 코드 데이터 출력
                    if obj.data is not None:
                        employeeNumber = int(obj.data.decode('utf-8'))
                        cap.release()
                        url_Readid = url + '/Readid'
                        params = {
                            'employeeNumber': employeeNumber,
                            'date': Date,
                        }
                        response = requests.get(url_Readid, params=params)
                        result_id = response.json()
                        if result_id:
                            Num = int(result_id['num'])
                        else:
                            Num = 0
                        print(Num)
                        url_Updateleave = url + '/Updateleave'
                        params = {
                            'end_time' : Time,
                            'num' : Num,
                        }
                        response = requests.get(url_Updateleave, params=params)
                        checkQr = True
            except Exception as e:
                url_UpdateInfo = url + '/InsertInfo'
                headers = {'Content-Type' : 'application/json'}
                data = {
                    'employeeNumber': employeeNumber,
                    'date': Date,
                    'start_time':Time,           
                }
                response = requests.post(url_UpdateInfo, headers=headers, json=data)
                print("error : ", e)
                checkQr = True
            if checkQr:
                check_qr()
        manager.update(time_delta)
        working.fill((myColor))
        if ret:
            working.blit(frame, (90, 80))
        working.blit(timer_label, (350, 50))
        working.blit(text_check, (245, 20))
        manager.draw_ui(working)
        home_button.draw(working)
        pygame.display.flip()
    pygame.quit()
                  
running = True
while running: 
    start()
    for event in pygame.event.get():
        if event.type == pygame.QUIT:
                running = False
    pygame.display.flip()
pygame.quit()