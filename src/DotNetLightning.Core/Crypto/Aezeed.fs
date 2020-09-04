namespace DotNetLightning.Crypto



module Constants =
    /// CipherSeedVersion is the current version of the aezeed scheme as defined in this package.
    /// This version indicates the following parameters for the deciphered cipher seed: a 1 byte version, 2 bytes
    /// for the Bitcoin Days Genesis timestamp, and 16 bytes for entropy. It also governs how the cipher seed
    [<Literal>]
    let CIPHER_SEED_VERSION = 0
    
    [<Literal>]
    let DECIPHERED_CIPHER_SEED_SIZE = 19
    
    [<Literal>]
    let ENCIPHERED_CIPHER_SEED_SIZE = 33
    
    [<Literal>]
    let CIPHER_TEXT_EXPANSION = 4
    
    [<Literal>]
    let ENTROPY_SIZE = 16
    
    [<Literal>]
    let MNEMONIC_WORDS = 24

    [<Literal>]
    let SALT_SIZE = 5
    
    [<Literal>]
    let AD_SIZE = 6
    
    [<Literal>]
    let CHECKSUM_SIZE = 4
    
    [<Literal>]
    let KEY_LEN = 32
    
    [<Literal>]
    let BITS_PER_WORD = 11
    
    let SALT_OFFSET = ENCIPHERED_CIPHER_SEED_SIZE - CHECKSUM_SIZE - SALT_SIZE
    
    let CHECKSUM_OFFSET = ENCIPHERED_CIPHER_SEED_SIZE - CHECKSUM_SIZE
    
    let ENCIPHERED_SEED_SIZE = DECIPHERED_CIPHER_SEED_SIZE + CIPHER_TEXT_EXPANSION
