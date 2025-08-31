"""A simple implementation of the Diffie-Hellman key exchange"""

import secrets

def private_key(p):
    generator = secrets.SystemRandom()
    return generator.randint(2,p-1)


def public_key(p, g, private):
    return (g ** private) % p


def secret(p, public, private):
    return (public ** private) % p
