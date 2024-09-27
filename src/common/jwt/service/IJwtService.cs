namespace common.jwt {
  public interface IJwtService {
    string generateToken(Dictionary<string, string> claims, DateTime expireDate);
  }
}