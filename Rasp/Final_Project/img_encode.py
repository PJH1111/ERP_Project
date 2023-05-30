import base64

def Img_encode(filename):
    with open(filename, 'rb') as f:
        binary_data = f.read()

    # QRcode 이미지 데이터를 base64 인코딩
    img_base64 = base64.b64encode(binary_data).decode('utf-8')
    return img_base64