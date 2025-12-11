class User:
    def __init__(self, name: str, age: int, email: str) -> None:
        self.name = name
        self.age = age
        self.email = email
    
    def log_in(self) -> None:
        print(f'User {self.email} logged in successfully.')
    

farrah = User(name='Farrah Pepino', age=22, email='farrahpepino@email.com')

print(farrah.name)
print(farrah.age)
print(farrah.email)
farrah.log_in()