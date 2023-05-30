import qrcode

myColor = (33,40,45)

def Create_qr(username):
    qr = qrcode.QRCode(
        version=None,
        error_correction=qrcode.constants.ERROR_CORRECT_L,
        box_size=10,
        border=5,
    )
    qr.add_data(username)
    qr.make(fit=True)
    img = qr.make_image(fill_color="white", back_color=myColor)
    
    filename = username +'.bmp'
    img.save(filename)
    return filename