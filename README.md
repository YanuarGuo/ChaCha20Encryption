# ChaCha20 Encryption Tool

## Overview
This application is a Windows Forms-based tool for encrypting and decrypting text using the ChaCha20 encryption algorithm. It supports multiple variations of ChaCha20, including ChaCha7539 and ChaCha20-Poly1305, implemented using the Bouncy Castle cryptographic library.

## Features
- Encrypt and decrypt text using ChaCha20 algorithms.
- Supports three modes: 
  - `ChaChaEngine20`
  - `ChaCha7539Engine`
  - `ChaCha20-Poly1305`
- Configurable nonce and initialization counter.
- Supports output formats in HEX or Base64.
- Auto-generate nonce using a random generator.
- Hash-based key generation.
- Simple UI with real-time encryption/decryption feedback.

## Prerequisites
- .NET 8.0 or higher
- BouncyCastle.Crypto library
- Visual Studio (for development)

## Installation
1. Clone the repository or download the source code.
2. Open the project in Visual Studio.
3. Restore NuGet packages if needed.
4. Build and run the application.

## Usage
### 1. Configuration
- Enter a 32-byte encryption key.
- Enter a nonce value (length depends on the selected algorithm).
- Select an encryption algorithm.
- Set the initialization counter (if required).
- Click `Confirm` to enable encryption and decryption.

### 2. Encryption
- Input plaintext.
- Select the output format (HEX or Base64).
- Click `Encrypt` to generate the encrypted text.

### 3. Decryption
- Input the encrypted text.
- Select the input format (HEX or Base64).
- Click `Decrypt` to retrieve the original plaintext.

### 4. Auto-generate Nonce
- Check the `Auto-Generate Nonce` box to generate a random nonce.

## Algorithm Details
- **ChaChaEngine20**: Uses an 8-byte nonce and requires an initialization counter.
- **ChaCha7539Engine**: Uses a 12-byte nonce and a fixed counter of `0`.
- **ChaCha20-Poly1305**: Uses a 12-byte nonce and a fixed counter of `1` with authentication support.

## Author
**Yanuar Christy Ade Utama**  
📧 yanuarchristyadeutama@gmail.com

